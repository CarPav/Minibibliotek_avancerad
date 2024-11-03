using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Minibibliotek_avancerad
{
    public class Database
    {
        [JsonPropertyName("books")]
        public List<Book> allBooksDB { get; set; }
    }
}
