using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyRestAPI_ASP_Net_Core_MusicAPI.Models;

namespace UdemyRestAPI_ASP_Net_Core_MusicAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SongsController : Controller
    {
        private static List<Song> songs = new List<Song>()
        {
            new Song(){ Id = 0, Title = "Another One Bites the Dust", Language = "English" },
            new Song(){ Id = 1, Title = "Little Boxes", Language = "English" },
            new Song(){ Id = 2, Title = "Where You Going Now", Language = "English" }
        };

        [HttpGet]
        public IEnumerable<Song> Get()
        {
            return songs; 
        }

        [HttpPost]
        public void Post([FromBody]Song song)
        {
            songs.Add(song);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Song song)
        {
            songs[id] = song;

        }

        [HttpDelete("{id}")]
        public void Delete(int id) 
        {
            songs.RemoveAt(id);
        } 

    }
}
