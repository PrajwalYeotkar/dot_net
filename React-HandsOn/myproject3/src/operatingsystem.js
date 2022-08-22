import React,{Component} from "react"
class OperatinSystem extends Component{
    constructor(props){
        super(props);
        this.state= {'OS':'iOS'};
        this.state={'Brand':'Apple'};
        this.state={'Model':'Iphone14'};
    }

    render(){
        return(
            <div>
                <h1>My brand is {this.state.Brand} and model is {this.state.Model}.</h1>
            </div>
        );
    }
}

export default OperatinSystem;