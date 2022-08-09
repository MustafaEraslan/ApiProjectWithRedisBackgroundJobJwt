# MustafaEraslanGraduationProject
## Arvato .Net Development Bootcamp Graduation Project

Hello, 

The "endpoints" I have completed in my project are as in the subsection. 

![image](https://user-images.githubusercontent.com/44713722/179116148-d20a74fe-b2de-4631-892f-6075f43d45e1.png)
![image](https://user-images.githubusercontent.com/44713722/179116167-706cac32-15d7-4626-809a-328607ef4169.png)

In general, the structure I created is as in the subsection.

![image](https://user-images.githubusercontent.com/44713722/179223561-4169b47f-73a4-4e9e-9c2a-d486e2f277d0.png)
![image](https://user-images.githubusercontent.com/44713722/179223639-1d692a25-f1ff-4a7f-ba7e-ee38ab396280.png)


We were given .csv data for the project. In this data structure, there were data structures such as json, json[], date.

In the project, I started by creating a Controller construction in the first place. My Controller folder contains "GenresController.cs", "MovieController.cs", "TrendingController.cs" and "UserController.cs".

For security purposes, I made it mandatory to take Jwt Token in put post and delete methods. Adding tokens is required for Post, Put and delete.

With GenresController.cs, I wrote the methods that I can do the work specified in the project.

Some of the errors I encountered in the project are as follows:

PostgresException: 23505: duplicate key value violates unique constraint
value too long for type character varying(255) for length 100000
Strange PostgreSQL "value too long for type character varying(500)"
Error: An error occurred while saving the entity changes in .NET
Cannot deserialize the current JSON objectinto type 'System.Collections.Generic.List because the type requires a JSON arrayto deserialize correctly
duplicate key value violates unique constraint EF core
Duplicate key value violates unique constraint (EF Core & PostgresSQL)
PostgresException: 23505: duplicate key value violates unique constraint "PK_country"

My method and methodology for solving errors;

-I proceeded step by step by putting "break points" for the points where I got an error in the project. I have often used the stackoverflow platform to handle every error received. I did research on similar projects on Github.

What did I learn by completing the project? What are my gains?

-I learned how to integrate Jwt token in the project. I used postgresql for the first time and gained experience on how to connect with postgresql. I learned how to handle json data with different data types, for example 3-4 different parameters in a column. I saw how I should import such data to the db side. What is redis used for in projects? I tried to find answers to the questions of what is a backgroundjob written for. I have found answers to the questions of when to use DbFirst and when to use CodeFirst.

What could I have done better? What did I do well?

When adding a movie, instead of entering json data from the user, I could have given it as property and only entered the value. For example, I want the user to enter json data such as genres in json format. When I tried this side, I couldn't progress because of the errors I got. On the other hand, I could add an authorize button for jwt token in swagger, but unfortunately I could not complete it in program.cs.
All my endpoints are working successfully for this and I am happy to see that the project has contributed to my development.

My tests are as follows;

[HttpGet] Genres information of the movie can be called by giving movieId value with "ListGenres".
For example;

![image](https://user-images.githubusercontent.com/44713722/179119297-2ea7287c-ef3a-43db-bdf2-09cf2794f92d.png)

[HttpPost] Genre details of the movie can be added with "AddGenre" (Jwt token should be taken for security reasons)
For example, the genres value of the movie with id 416437 is empty. We can add genre with AddGenre. It successfully added as below.

![image](https://user-images.githubusercontent.com/44713722/179119652-69440600-7ea9-4599-95ee-e9e64df310d0.png)

When we get the movie with id 416437, we see that the genres data is now full.

![image](https://user-images.githubusercontent.com/44713722/179120359-a3a8edd8-f330-42f9-aad3-578a295a12e3.png)

[HttpPut] With UpdateGenre, the genre information of the movie can be updated by giving the movieId value.

![image](https://user-images.githubusercontent.com/44713722/179120573-dc749913-6f3b-41ce-ae9c-ea5da9e5b712.png)

When the same movie is made, we see that the previous genre value is updated.

![image](https://user-images.githubusercontent.com/44713722/179120623-bb7d8f15-ecfa-4d28-ba6e-c42b45932f46.png)

[HttpDelete] With DeleteGenre, the genre of the movie can be deleted according to the movieId value.

![image](https://user-images.githubusercontent.com/44713722/179120847-9d233df4-adc0-44b5-a633-046e45a11468.png)

It seems that the same movie is deleted when get is done.

![image](https://user-images.githubusercontent.com/44713722/179120903-60cbc0ca-74f0-416c-99b8-362a4a6041dd.png)

#For movies;
[HttpGet] /api/Movies/GetMovieDeail You can bring movie details with . In the same way, genre details are brought with GetMovieListGenre.
For example,

![image](https://user-images.githubusercontent.com/44713722/179121072-f64f0165-19dc-4928-9b10-00032f62e3b4.png)

[HttpGet] I used "Postman" for "/api/Movies/GetMovieListRate". I decided to test it with Postman because Swagger received a lot of data and responded late.

![image](https://user-images.githubusercontent.com/44713722/179121450-6aae241c-1226-4e2c-b6d2-ae5ff1306674.png)

[HttpGet] Successfully getting response for "/api/Movies/GetMovieListRelease" with date 1996-09-10 as in subsection.

![image](https://user-images.githubusercontent.com/44713722/179121772-3ca06793-2042-4d14-95f8-1506f58d1291.png)

[HttpGet] When I search the data named "Time Tracers" for "/api/Movies/Search", the details of this movie come up by name successfully.

![image](https://user-images.githubusercontent.com/44713722/179121927-f7a1272f-3fde-483c-89aa-7b5e7ef3db49.png)

[HttpPost] When the json data in the subsection is sent for "/api/Movies", the movie is successfully added. Here, it is necessary to pay attention to the character limit in the database. Especially "original language", "video" columns should not be given more than 5 characters.

{
  "adult": "false",
  "belongsToCollection": "{'id': 10194, 'name': 'Toy Story Collection', 'poster_path': '/7G9915LfUQ2lVfwMEEhDsn3kT4B.jpg', 'backdrop_path': '/9FBwqcd9IRruEDUrTdcaafOMKUq.jpg'}",
  "budget": "string",
  "genres": "[{'id': 16, 'name': 'Animation'}, {'id': 35, 'name': 'Comedy'}, {'id': 10751, 'name': 'Family'}]",
  "homepage": "string",
  "id": 445592,
  "imdbId": "string",
  "originalLanguage": "tr",
  "originalTitle": "tr",
  "overview": "string",
  "popularity": "string",
  "posterPath": "string",
  "productionCompanies": "[{'name': 'Pixar Animation Studios', 'id': 3}]",
  "productionCountries": "[{'iso_3166_1': 'US', 'name': 'United States of America'}]",
  "releaseDate": "string",
  "revenue": 0,
  "runtime": 0,
  "spokenLanguages": "[{'iso_639_1': 'en', 'name': 'English'}]",
  "status": "string",
  "tagline": "string",
  "title": "string",
  "video": "tr",
  "voteAverage": 0,
  "voteCount": 0
}

![image](https://user-images.githubusercontent.com/44713722/179122683-a2c37edc-483b-4d2d-abc5-b033e492ad59.png)

In addition, when we check it through the database, we see that this record has arrived.

![image](https://user-images.githubusercontent.com/44713722/179122767-1799480f-474b-4328-b278-9611e03aa021.png)

[HttpPut] Existing movies can be updated with "/api/Movies/{id}". For example, I updated the original_language value of the movie with id 427043 to fr.

![image](https://user-images.githubusercontent.com/44713722/179123218-fd0606d1-e6e5-4fbe-b4b8-32a5c4c22e07.png)

[HttpDelete] With "/api/Movies/{id}", movie details can be deleted based on id.

![image](https://user-images.githubusercontent.com/44713722/179123379-696c1dec-ef92-476a-920e-b1c92db79bb3.png)

When we check again from the database, we see that this data has been deleted.

![image](https://user-images.githubusercontent.com/44713722/179123464-2e0f791c-baa2-43dc-87d0-3618bdd7da81.png)

#Trendings

[HttpGet] "/api/Trend/ListMostViewedMovies" lists the most watched movies.

![image](https://user-images.githubusercontent.com/44713722/179123839-765c6bb7-6198-4507-b1c9-a6359acc77ea.png)

[HttpGet] With "/api/Trendings/ListTopRatedMovies", they get the highest rate points.

![image](https://user-images.githubusercontent.com/44713722/179124045-922ffc60-f1be-44b5-ba6f-bd696c552a85.png)

And getting JWT token for user. I had inserted the username: mustafaeraslan Password: 123 data into the User table.

![image](https://user-images.githubusercontent.com/44713722/179124154-9d93c235-bb7d-45f0-957f-d643a3fc65a1.png)


I would like to thank everyone for this project that contributed to my personal development.

Best regards,
