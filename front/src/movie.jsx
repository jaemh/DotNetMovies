import React, { Component } from "react";

class Movie extends Component {
  render() {
    return (
      <div>
        {this.props.movieName} {this.props.movieYear}
      </div>
    );
  }
}

export default Movie;
