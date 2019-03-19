import React, { Component } from "react";
import Movie from "./movie.jsx";

class MovieList extends React {
  constructor(props) {
    super(props);
    this.state = { data: [] };
  }

  loadMovies() {
    var url = "/api/movies";
    const xhr = new XMLHttpRequest();
    xhr.open("get", this.props.url, false);
    xhr.onload = () => {
      const data = JSON.parse(xhr.responseText);
      this.setState({ data: data });
    };
    xhr.send();
  }

  //WARNING! To be deprecated in React v17. Use componentDidMount instead.
  componentWillMount() {
    this.loadMovies();
  }

  render() {
    const movies = this.state.data.map(m => (
      <Movie key={m.id} movieName={m.name} movieYear={m.year} />
    ));

    return <div>{movies}</div>;
  }
}

export default MovieList;
