import React from "react";
import ReactDOM from "react-dom";
import MovieList from "./movieList.jsx";

class App extends React.Component {
  render() {
    return (
      <div>
        <MovieList />
      </div>
    );
  }
}

ReactDOM.render(<App />, document.getElementById("container"));
