﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MailChimp.Net.Models
{
    public class Line
    {

        public Line()
        {
            this.Links = new List<Link>();
        }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        [JsonProperty("product_title")]
        public string ProductTitle { get; set; }

        [JsonProperty("product_variant_id")]
        public string ProductVariantId { get; set; }

        [JsonProperty("product_variant_title")]
        public string ProductVariantTitle { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("_links")]
        public IList<Link> Links { get; set; }
    }
}
