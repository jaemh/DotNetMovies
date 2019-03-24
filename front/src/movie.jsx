import React, { Component } from "react";

class Movie extends Component {
  render() {
    return (
      <div>
        {this.props.movieName} {this.props.movieYear} {this.props.movieDesc}
      </div>
    );
  }
}

export default Movie;
