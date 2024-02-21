# All Movies Of The Actors API 🎬

This project provides an API that lists the information of the desired film and all other films of the lead actors in the film and short summaries of these films. With the movieName parameter, it is sufficient to send only the name of the film to the API.

In this project, AllMoviesOfTheActors API was created by organising and combining two APIs with similar topics but different aspects.

## Technologies Used

**Languages:** C#

**Frameworks:** .Net

**Environments:** Visual Studio

**Testing:** Postman

**API Sites Used:** omdbapi.com, rapidapi.com

## API Usage

#### GET Item

```http
  GET /api/AMAA/MovieAndActors?{movieName}
```

| Parameter | Type | Description                      |
| :-------- | :------- | :-------------------------------- |
| `movieName`      | `String` |  Movie Name **(Necessary)**|

+ #### MovieAndActors(movieName)
The method is called with the movieName parameter. First, the film name is sent to the OMDB api and the return is received and placed in the model. Then the actor names returned from OMDB apis are sent to RAAM apis and the return is received and placed in the model as lists. Finally, AMAA model is created by selecting the desired data in both models. All this information is transferred as API.

#### Example:

+ Request:

```http
  GET /api/AMAA/MovieAndActors?movieName=titanic
```

+ Response:

```json
{
"Title": "Titanic",
"Year": "1997",
"Released": "19 Dec 1997",
"Runtime": "194 min",
"Genre": "Drama, Romance",
"Director": "James Cameron",
"Writer": "James Cameron",
"Actors": [
    {
    "name_surname": "Leonardo DiCaprio",
    "ActorsMovies": 
        {
        "original_title": "Inception",
        "english_title": "Inception",
        "overview": "Cobb, a skilled thief who commits corporate espionage by infiltrating the subconscious of his targets is offered a chance to regain his old life as payment for a task considered to be impossible: "inception", the implantation of another person's idea into a target's subconscious.",
        "character": "Dom Cobb",
        "release_date": "2010-07-15",
        "poster_path": "https://image.tmdb.org/t/p/original/oYuLEt3zVCKq57qu2F8dT7NIa6f.jpg",
        "original_language": "en"
        },
        .
        .
        .
        "(Only one block is shown so that the api rotation can be understood.)"
    },
    {
    "name_surname": " Kate Winslet",
    "ActorsMovies": [.. 70 Items ..]
    },
    {
    "name_surname": " Billy Zane",
    "ActorsMovies": [.. 142 Items ..]
    }
],
"Plot": "A seventeen-year-old aristocrat falls in love with a kind but poor artist aboard the luxurious, ill-fated R.M.S. Titanic.",
"Language": "English, Swedish, Italian, French",
"Country": "United States, Mexico",
"Awards": "Won 11 Oscars. 126 wins & 83 nominations total",
"Poster": "https://m.media-amazon.com/images/M/MV5BMDdmZGU3NDQtY2E5My00ZTliLWIzOTUtMTY4ZGI1YjdiNjk3XkEyXkFqcGdeQXVyNTA4NzY1MzY@._V1_SX300.jpg",
"Ratings": [
    {
    "Source": "Internet Movie Database",
    "Value": "7.9/10"
    },
    {
    "Source": "Rotten Tomatoes",
    "Value": "88%"
    },
    {
    "Source": "Metacritic",
    "Value": "75/100"
    }
],
"imdbRating": "7.9",
"imdbVotes": "1,267,049",
"imdbID": "tt0120338",
"Type": "movie",
"BoxOffice": "$674,292,608"
}
```

## APIs Keys

#### OMDB Api

If you want, you can use the api key directly in the project or you can get your own api key from this [link](https://www.omdbapi.com/apikey.aspx). There is a limit of 1000 requests per day for free.

#### RAAM Api

Rapid Api site contains paid and free apis in different categories. Each user has a unique Rapid-Api key. Therefore, this key is hidden in the project. You can create your own api key at this [link](https://rapidapi.com/auth/sign-up).

+ The RAAMKey.txt file was created to store the Rapid-api key in a secure and easy-to-use way. After generating your own Rapid-api key, paste the key into the file.
## Run On Your Computer

Here is what you need to do to run this project on your own computer:
+ Download the project to your computer by cloning it. (git clone https://github.com/yigitkalay/AllMoviesOfTheActorsAPI)
+ Enter the ProjectAMAA folder and create your RAAMKey.txt file in the folder as shown.
+ Everything is done. Now all you have to do is run the project and sit back 🥳

## Lessons Learned

Bu projede benzer konuları ele alsalar da farklı giriş ve dönüş parametrelerine sahip iki apiyi düzenleyerek yeni bir api yaratmayı öğrendim. Filmlerle çalışmak oldukça keyfiyliydi 🎬

## Feedback

If you have any feedback, please open an issue or contact me on linkedin. Good coding 👨🏻‍💻
