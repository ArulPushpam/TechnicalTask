using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Xcentium_Techincal_Code.Models;

namespace Xcentium_Techincal_Code.Services
{
    public class GetWordCount
    {
        public List<WordOccuranceModel> CalcualteWordOccurance(string siteUrl)
        {
            if (string.IsNullOrEmpty(siteUrl))
                throw new ArgumentException("websiteUrl Cannot be null");

            Uri url = new Uri(siteUrl);
            WebClient client = new WebClient();
            client.Encoding = System.Text.Encoding.UTF8;
            string html = client.DownloadString(url);
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            List<string> totalWords = new List<string>();

            char[] delimiter = new char[] { ' ' };
            int totalword = 0;
            foreach (string text in doc.DocumentNode
                .SelectNodes("//body//text()[not(parent::script)]")
                .Select(node => node.InnerText))
            {
                var words = text.Split(delimiter, StringSplitOptions.RemoveEmptyEntries)
                    .Where(s => Char.IsLetter(s[0]));
                totalWords.AddRange(words);
                int wordCount = words.Count();
                if (wordCount > 0)
                {
                    totalword += wordCount;
                }
            }

          return  totalWords.Where(s => s.Length > 3).GroupBy(s => s).OrderByDescending(g => g.Count()).
                Select(x => new WordOccuranceModel() { Count = x.Count(), Word = x.Key }).Take(10).ToList();
        }
    }
}
