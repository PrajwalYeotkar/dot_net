import React, { Component } from 'react'
import ReactDOM from 'react-dom'
import {Provider} from 'react-redux'

import {App} from './App'
import createStore from './createReduxStore'

const store = createStore()

//As of react18
const root = ReactDOM.createRoot(document.getElementById('root'))
root.render(
    <Provider store ={store}>
        <App/>
    </Provider>
)