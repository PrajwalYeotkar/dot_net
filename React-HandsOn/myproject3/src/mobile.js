import React, {Component } from 'react'
class Mobile extends Component {
    constructor(props) {
        super(props);

        this.state = { 'Brand': 'Apple', 'Model': 'Iphone14' };

    }

    render() {
        return (
            <div>
                <h1>My phone's brand is {this.state.Brand} and the model is {this.state.Model}.</h1>
            </div>
        );
    }
}
export default Mobile;
