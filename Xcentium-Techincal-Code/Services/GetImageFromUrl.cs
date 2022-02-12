using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace Xcentium_Techincal_Code.Services
{
    public class GetImageFromUrl
    {
        public List<string> ImageUrl(string websiteUrl)
        {
            // For speed of dev, I use a WebClient
            WebClient client = new WebClient();
            if (string.IsNullOrEmpty(websiteUrl))
                throw new ArgumentException("websiteUrl Cannot be null");

            string html = client.DownloadString(websiteUrl);

            // Load the Html into the agility pack
            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);

            // Now, using LINQ to get all Images
            List<HtmlNode> imageNodes = null;
            imageNodes = (from HtmlNode node in doc.DocumentNode.SelectNodes("//img")
                          where node.Name == "img"
                          select node).ToList();
            List<string> image_links = new List<string>();

            foreach (HtmlNode node in imageNodes)
            {
                image_links.Add(node.Attributes["src"].Value);
            }
            return image_links;
        }
    }
}
