import React from 'react';
class Car extends React.Component{
//state:values
//props:properties
constructor(props){
    super(props);//it refers to the properties of the React.component
    //store contains props+state
    this.state = {brand:"Ford"};
    this.state = {carname:"Ford"};
    this.state = {carbrandname:"Ford"};
    this.state = {make:"Ford"};
    this.state = {model:"Ford"};
    this.state = {brand:"Tata"};
//This properties and states are stored in a store

}

render(){
    return(
        <div>
            <h1>My Car {this.state.brand} and model {this.state.model}</h1>
        </div>
    );
    }
}
export default Car;
