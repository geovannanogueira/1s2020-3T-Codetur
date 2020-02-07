import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';


import App from './Login/App';
import pacotes from './Pacotes/App';
import lista from './Listas/lista';

import { Route, BrowserRouter as Router, Switch} from "react-router-dom";

import * as serviceWorker from './serviceWorker';


// const RotaPrivada = ({component: Component}) => (
//     <Route
//         render ={ props =>
//         localStorage.getItem("usuario-codetur") !== null && parseJwt().adm === "Administrador" ?
//         (
//             <Component {...props}/>
//         ) : (
//             <Redirect 
//                 to={{pathname: "/", state: {from: props.location}}}
//             />
//         )
//     }
//     />
// )

const routing = (
    <Router>
        <div>
            <Switch>
                <Route exact path='/' component={App}/>
                <Route path='/pacotes' component={pacotes}/>
                <Route path='/lista' component={lista}/>
            </Switch>
        </div>
    </Router>
)



ReactDOM.render(routing, document.getElementById('root'));

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();
///////////