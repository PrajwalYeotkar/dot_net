//import logo from './logo.svg';
import './App.css';

function App() {
  return (
    <div className="App">
      <AppChild name="Matt"/>
    </div>
  );
}

function AppChild(props)
{
  return <span>
      My name is {props.name}
    </span>
}

//ReactDOM.render(<App />, document.getElementById('app'));


export default App;
