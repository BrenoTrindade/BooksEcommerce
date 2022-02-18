﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
        new Product
        {
            ID = 1,
            Title = "Harry Potter and the Philosopher's Stone",
            Description = "Harry Potter and the Philosopher's Stone (released in the United States, India and the Philippines as Harry Potter and the Sorcerer's Stone) is a 2001 fantasy film directed by Chris Columbus and distributed by Warner Bros. Pictures, based on J. K. Rowling's 1997 novel of the same name. Produced by David Heyman and screenplay by Steve Kloves, it is the first instalment of the Harry Potter film series. The film stars Daniel Radcliffe as Harry Potter, with Rupert Grint as Ron Weasley, and Emma Watson as Hermione Granger. Its story follows Harry's first year at Hogwarts School of Witchcraft and Wizardry as he discovers that he is a famous wizard and begins his formal wizarding education.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/c/c1/Capa_HP1.jpg",
            Price = 9.99m
        },

        new Product
        {
            ID = 1,
            Title = "Harry Potter and the Chamber of Secrets",
            Description = "Harry Potter and the Chamber of Secrets is a fantasy novel written by British author J. K. Rowling and the second novel in the Harry Potter series. The plot follows Harry's second year at Hogwarts School of Witchcraft and Wizardry, during which a series of messages on the walls of the school's corridors warn that the Chamber of Secrets has been opened and that the heir of Slytherin would kill all pupils who do not come from all-magical families. These threats are found after attacks that leave residents of the school petrified. Throughout the year, Harry and his friends Ron and Hermione investigate the attacks.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/9/97/Capa_HP2.jpg",
            Price = 7.99m
        },

        new Product
        {
            ID = 1,
            Title = "Harry Potter and the Prisoner of Azkaban",
            Description = "Harry Potter and the Prisoner of Azkaban is a fantasy novel written by British author J. K. Rowling and is the third in the Harry Potter series. The book follows Harry Potter, a young wizard, in his third year at Hogwarts School of Witchcraft and Wizardry. Along with friends Ronald Weasley and Hermione Granger, Harry investigates Sirius Black, an escaped prisoner from Azkaban, the wizard prison, believed to be one of Lord Voldemort's old allies.",
            ImageUrl = "https://upload.wikimedia.org/wikipedia/pt/e/eb/Capa_HP3.jpg",
            Price = 6.99m
        }
        };
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProducts()
        {
            return Ok(Products);
        }
    }
}
