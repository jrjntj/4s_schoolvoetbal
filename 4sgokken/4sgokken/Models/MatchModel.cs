﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace REST_Voetbal.Models
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<List<Root>>(myJsonResponse);
    public class MatchModel
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("team1_id")]
        public int Team1Id { get; set; }

        [JsonPropertyName("team1_name")]
        public string Team1Name { get; set; }

        [JsonPropertyName("team2_id")]
        public int Team2Id { get; set; }

        [JsonPropertyName("team2_name")]
        public string Team2Name { get; set; }
    }


}
