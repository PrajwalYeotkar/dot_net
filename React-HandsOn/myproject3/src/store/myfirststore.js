import { createStore } from 'reduxjs'


function counter (state = { value: 0 }, action) {
    switch (action.type) {
    case 'INCREMENT':
      return { value: state.value + 1 }
    case 'DECREMENT':
      return { value: state.value - 1 }
    default:
      return state
    }
  }
  let myfirststore = createStore(counter)

    myfirststore.dispatch({ type: 'INCREMENT' })
    myfirststore.dispatch({ type: 'DECREMENT' })

export default myfirststore;