
import './App.css';
import Mobile from './mobile';
import Tab from './Tab';
import OperatingSystem from './operatingsystem';


function App() {
  return (
    <div className="App">
      <Mobile />
      <Tab Brand="Samsung" Model ="Notebook"/>
      <OperatingSystem/>
    </div>
  );
}

export default App;
