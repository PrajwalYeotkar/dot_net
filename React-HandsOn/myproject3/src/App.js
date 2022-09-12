// import Mobile from './mobile';
// import Tab from './Tab';
// import OperatingSystem from './operatingsystem';
//import School1 from './school1';
//import School2 from './School2';
import React from 'react';
import './App.css';
import {myfirststore} from './store/myfirststore'
import {Provider} from 'react-redux'

function App() {
  return (
    <div className="App">
      {/* <Mobile />
      <Tab Brand="Samsung" Model ="Notebook"/>
      <OperatingSystem/> */}
      {/* <School1/>
      <School2/> */}
      <Provider myfirststore={myfirststore}> </Provider>
    </div>
  );
}

export default App;
