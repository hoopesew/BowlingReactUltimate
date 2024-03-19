import React from 'react';
import './App.css';
import Header from './header';
import BowlerList from './bowlers/bowlerlist';

function App() {
  return (
    <div className="App">
      <Header title="Bowlers Fun" />
      <BowlerList />
    </div>
  );
}

export default App;
