﻿using eTickets.Data.Context;
using eTickets.Data.Enums;
using eTickets.Data.Static;
using eTickets.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Data
{
    public class AppDbInitializier
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();

                context.Database.EnsureCreated();

                //Cinema
                if (!context.Cinemas.Any())
                {
                    context.Cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            Name = "Cinema 1",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 2",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 3",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 4",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                        new Cinema()
                        {
                            Name = "Cinema 5",
                            Logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            Description = "This is the description of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //Actors
                if (!context.Actors.Any())
                {
                    context.Actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            FulName = "Actor 1",
                            Bio = "This is the Bio of the first actor",
                            profilPctureUrl = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            FulName = "Actor 2",
                            Bio = "This is the Bio of the second actor",
                            profilPctureUrl = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            FulName = "Actor 3",
                            Bio = "This is the Bio of the second actor",
                            profilPctureUrl = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            FulName = "Actor 4",
                            Bio = "This is the Bio of the second actor",
                            profilPctureUrl = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            FulName = "Actor 5",
                            Bio = "This is the Bio of the second actor",
                            profilPctureUrl = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Producers
                if (!context.Producers.Any())
                {
                    context.Producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            FulName = "Producer 1",
                            Bio = "This is the Bio of the first actor",
                            profilPctureUrl = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            FulName = "Producer 2",
                            Bio = "This is the Bio of the second actor",
                            profilPctureUrl = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            FulName = "Producer 3",
                            Bio = "This is the Bio of the second actor",
                            profilPctureUrl = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            FulName = "Producer 4",
                            Bio = "This is the Bio of the second actor",
                            profilPctureUrl = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            FulName = "Producer 5",
                            Bio = "This is the Bio of the second actor",
                            profilPctureUrl = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //Movies
                if (!context.Movies.Any())
                {
                    context.Movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            Name = "Life",
                            Description = "This is the Life movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            BeginDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            CinemaId = 3,
                            ProducerId = 3,
                            movieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "The Shawshank Redemption",
                            Description = "This is the Shawshank Redemption description",
                            Price = 29.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            BeginDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            CinemaId = 1,
                            ProducerId = 1,
                            movieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            Name = "Ghost",
                            Description = "This is the Ghost movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            BeginDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(7),
                            CinemaId = 4,
                            ProducerId = 4,
                            movieCategory = MovieCategory.Horror
                        },
                        new Movie()
                        {
                            Name = "Race",
                            Description = "This is the Race movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            BeginDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-5),
                             CinemaId = 1,
                            ProducerId = 2,
                            movieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            Name = "Scoob",
                            Description = "This is the Scoob movie description",
                            Price = 39.50,
                            ImageUrl= "http://dotnethow.net/images/movies/movie-7.jpeg",
                            BeginDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(-2),
                             CinemaId = 1,
                            ProducerId = 3,
                            movieCategory = MovieCategory.Cartoon
                        },
                        new Movie()
                        {
                            Name = "Cold Soles",
                            Description = "This is the Cold Soles movie description",
                            Price = 39.50,
                            ImageUrl = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            BeginDate = DateTime.Now.AddDays(3),
                            EndDate = DateTime.Now.AddDays(20),
                             CinemaId = 1,
                            ProducerId = 5,
                            movieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //Actors & Movies
                if (!context.ActorsMovies.Any())
                {
                    context.ActorsMovies.AddRange(new List<ActorMovie>()
                    {
                        new ActorMovie()
                        {
                            ActorId = 1,
                            MovieId = 1
                        },
                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 1
                        },

                         new ActorMovie()
                        {
                            ActorId = 1,
                            MovieId = 2
                        },
                         new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 2
                        },

                        new ActorMovie()
                        {
                            ActorId = 1,
                            MovieId = 3
                        },
                        new ActorMovie()
                        {
                            ActorId = 2,
                            MovieId = 3
                        },
                        new ActorMovie()
                        {
                            ActorId = 5,
                            MovieId = 3
                        },


                        new ActorMovie()
                        {
                            ActorId = 2,
                            MovieId = 4
                        },
                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 4
                        },
                        new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 4
                        },


                        new ActorMovie()
                        {
                            ActorId = 2,
                            MovieId = 5
                        },
                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 5
                        },
                        new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 5
                        },
                        new ActorMovie()
                        {
                            ActorId = 5,
                            MovieId = 5
                        },


                        new ActorMovie()
                        {
                            ActorId = 3,
                            MovieId = 6
                        },

                        new ActorMovie()
                        {
                            ActorId = 4,
                            MovieId = 6
                        },
                        new ActorMovie()
                        {
                            ActorId = 5,
                            MovieId = 6
                        },
                    });

                    context.SaveChanges();
                }
            }
        }

    

        public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRole.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRole.Admin));
                if (!await roleManager.RoleExistsAsync(UserRole.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRole.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<ApplicationUser>>();
                var adminUserEmail = "zeri.q.222@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);

                if (adminUser == null) 
                {
                    var newAdminUser = new ApplicationUser()
                    {
                        FullName = "Admin User",
                        UserName = "admin-user",
                        Email = adminUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAdminUser, "Code1234!?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRole.Admin);
                }

                var appUserEmail = "zeri.q.222@gmail.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);

                if (appUser == null)
                {
                    var newAppUser = new ApplicationUser()
                    {
                        FullName = "Applicationn User",
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true
                    };
                    await userManager.CreateAsync(newAppUser, "Code1234!?");
                    await userManager.AddToRoleAsync(newAppUser, UserRole.Admin);
                }
            }
        }
    }
}
