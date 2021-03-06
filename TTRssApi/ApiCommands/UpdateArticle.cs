﻿// Copyright 2013 Claudio Bantaloukas
//
// This file is part of the C# api wrapper for tt-rss.
// The C# api wrapper for tt-rss is free software: you can redistribute it and/or modify it under the terms of 
// the GNU General Public License as published by the Free Software Foundation, either version 3 of the License, 
// or (at your option) any later version.
//
// The C# api wrapper for tt-rss is distributed in the hope that it will be useful, 
// but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or
// FITNESS FOR A PARTICULAR PURPOSE. See the GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License along with the C# api wrapper for tt-rss. 
// If not, see http://www.gnu.org/licenses/.


using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace TTRss.Api.Commands
{
    public class UpdateArticleRequest : TTRssApiRequest
    {

        [JsonProperty("article_ids")]
        public string article_ids { get; set; }

        [JsonProperty("mode")]
        public int mode { get; set; }

        [JsonProperty("field")]
        public int field { get; set; }

        [JsonProperty("data")]
        public string data { get; set; }

        public UpdateArticleRequest(int req)
        {
            this.sequence = req;
            this.operation = "updateArticle";
        }

        public UpdateArticleResponse response { get; set; }
    }

    public class UpdateArticleResponseContent
    {
        [JsonProperty("error")]
        public string error { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("updated")]
        public int Updated { get; set; }
    }

    public class UpdateArticleResponse
    {

        [JsonProperty("seq")]
        public int Seq { get; set; }

        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("content")]
        public UpdateArticleResponseContent Content { get; set; }
    }

}
