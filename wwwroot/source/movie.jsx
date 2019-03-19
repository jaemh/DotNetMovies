import React, { Component } from "react";

class Movie extends React {
  render() {
    return (
      <div>
        {this.props.movieName} {this.props.movieYear}
      </div>
    );
  }
}

export default Movie;
