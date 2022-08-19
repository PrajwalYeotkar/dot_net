import React from "react"
class engine extends React.Component{
    constructor(props){
        // this.state = {
        //     brand:"",
        //     model:"",
        //     make:""
        // }
        this.state = {brand:"Tata",model:"XUV"}
    }
    render(){
        return(
            <div>
                <h1>
                    My Car {this.state.brand} and Model {this.state.model}
                </h1>
            </div>
        );
    }
}