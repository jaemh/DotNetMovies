import React from "react";
import Movie from "./movie.jsx";

class MovieList extends React.Component {
  constructor(props) {
    super(props);
    this.state = { data: [] };
  }

  loadMovies() {
    fetch("http://localhost:5000/api/movies")
      .then(response => response.json())
      .then(data => this.setState({ data: data }));
  }

  componentWillMount() {
    this.loadMovies();
  }

  render() {
    const movies = this.state.data.map(m => (
      <Movie
        key={m.id}
        movieName={m.name}
        movieYear={m.year}
        movieDesc={m.description}
      />
    ));

    return <div>{movies}</div>;
  }
}

export default MovieList;
