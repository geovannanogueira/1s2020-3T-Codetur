import React from 'react';
import Axios from 'axios';

import logo from '../assets/fotos/logo.png';

export default class Login extends React.Component {

    constructor() {
        super();
        this.state = {
            email: "",
            senha: "",
            erro: "",
        }
    }

    email = (event) => {
        this.setState({ email: event.target.value })
    }

    senha = (event) => {
        this.setState({ senha: event.target.value })
    }

    efetuarLogin = (event) => {
        event.preventDefault();

        Axios.post("http://localhost:5000/api/login", {
            email: this.state.email,
            senha: this.state.senha
        })
            .then(data => {
                if (data.status === 200) {
                    localStorage.setItem("usuario-codetur", data.data.token);
                    this.props.history.push('/pacotes')
                } else {
                    console.log("Não deu certo!")
                }
            })
            .catch(erro => {
                this.setState({ erro: <div className='erro'>Usuário ou senha inválido</div> });
                console.log(erro);
            })
    }


    render() {
        return (
            <div className="App">
                <header id="corpo-login">
                    <div className="container">
                        <img src={logo} />
                    </div>
                </header>
                <section>
                    <form onSubmit={this.efetuarLogin}>
                        <div>
                            <input className="input_login" placeholder="   Email" type="email" name="username" id="login_email" onChange={this.email} value={this.state.email} />
                        </div>
                        <div>
                            <input className="input_login" placeholder="   Senha" type="password" name="password" id="login_senha" onChange={this.senha} value={this.state.senha} />
                        </div>
                        <div>
                            <button className="btn_login" id="botao_login">Efetuar Login</button>
                        </div>
                        {this.state.erro}
                    </form>
                </section>
            </div>
        );
    }
}