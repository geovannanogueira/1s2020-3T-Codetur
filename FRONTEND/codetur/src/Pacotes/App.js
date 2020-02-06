import React from 'react';
import {Link} from 'react-router-dom'
import Axios from 'axios'

import logo from '../assets/fotos/logo.png';

export default class Pacotes extends React.Component{

    constructor() {
        super()
        this.state = {
            lista: [],
        }
    }

    componentDidMount() {
        this.listarPacotes();
    }

    listarPacotes = () => {
        Axios.get('http://localhost:5000/api/pacotes', {
            headers: { 'Authorization' : 'Bearer ' + localStorage.getItem('usuario-codetur')}
        })
            .then(response => {
                this.setState({lista : response.data })
                console.log({ lista: response.data})
            })
    }

    render() {
        return(
            <div className="AppP">
                <header className="container">
                    <Link id="Link" to='/'>Logout</Link>
                </header>
                <section className="conteudo">
                    <div className="ihhmiga">
                        
                    </div>
                </section>
            </div>
        );
    }

}