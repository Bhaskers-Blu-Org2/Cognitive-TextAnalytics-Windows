﻿using Microsoft.ProjectOxford.Text.Sentiment;
using System;

namespace SentimentClientSync
{
    class Program
    {
        static void Main(string[] args)
        {
            var apiKey = "YOUR-TEXT-ANALYTICS-API-SUBSCRIPTION-KEY";

            var document = new SentimentDocument()
            {
                Id = "YOUR-UNIQUE-ID",
                Text = "YOUR-TEXT",
                Language = "en"
            };

            var request = new SentimentRequest();
            request.Documents.Add(document);

            var client = new SentimentClient(apiKey);

            var response = client.GetSentiment(request);

            foreach (var doc in response.Documents)
            {
                Console.WriteLine("   Document Id: {0}", doc.Id);
                Console.WriteLine("   Score: {0}%", (doc.Score * 100));
            }

            Console.WriteLine("   Press any key to exit...");
            Console.ReadLine();
        }
    }
}
