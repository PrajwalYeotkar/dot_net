import React, { Component } from 'react'

class School1 extends Component {
  constructor(props){
    super(props);
    this.state={"SchoolName":"StClaretSchool" ,"Address":"Nagpur" };
  }
  render() {
    return (
      <div>
        <h1>My school name is {this.state.SchoolName} and address is {this.state.Address}</h1>
      </div>
    );
  }
}

export default School1