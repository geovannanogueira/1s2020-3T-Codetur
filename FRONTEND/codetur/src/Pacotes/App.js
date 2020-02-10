import React from 'react';
import { Link } from 'react-router-dom'
import Axios from 'axios'
import './pacotes.css';
import logo from '../assets/fotos/logo.png';

export default class Pacotes extends React.Component {

    constructor() {
        super()
        this.state = {
            lista: [],
            titulo: "",
            imagem: "",
            descricao: "",
            dataInicial: "",
            dataFinal: "",
            pais: "",
            ativo: "",
            oferta: ""
        }
    }

    estadoTitulo = (event) => {
        this.setState({ titulo: event.target.value })
        console.log(this.state.titulo)
    }

    estadoImagem = (event) => {
        this.setState({ imagem: event.target.value })
        console.log(this.state.imagem)
    }

    estadoDescricao = (event) => {
        this.setState({ descricao: event.target.value })
        console.log(this.state.descricao)
    }

    estadoDataInicial = (event) => {
        this.setState({ dataFinal: event.target.value })
        console.log(this.state.dataFinal)
    }

    estadoDataFinal = (event) => {
        this.setState({ dataInicial: event.target.value })
        console.log(this.state.dataInicial)
    }

    estadoPais = (event) => {
        this.setState({ pais: event.target.value })
        console.log(this.state.pais)
    }

    estadoAtivo = (event) => {
        this.setState({ ativo: event.target.value })
        console.log(this.state.ativo)
    }

    estadoOferta = (event) => {
        this.setState({ oferta: event.target.value })
        console.log(this.state.oferta)
    }

    Cadastrar = (event) => {
        event.preventDefault();

        fetch("http://localhost:5000/api/pacotes", {
            method: "POST",
            body: JSON.stringify({
                titulo: this.state.titulo,
                imagem: this.state.imagem,
                descricao: this.state.descricao,
                dataInicial: this.state.dataInicial,
                dataFinal: this.state.dataFinal,
                pais: this.state.pais,
                ativo: this.state.ativo,
                oferta: this.state.oferta
            }),
            headers: {
                "Content-Type": "application/json",
                Authorization: "Bearer " + localStorage.getItem("usuario-codetur")
            }
        })
            .then(console.log("deu certo!"))

            .catch(erro => {
                console.log(erro);
            })
    }

    // componentDidMount() {
    //     this.listarPacotes();
    // }

    // listarPacotes = () => {
    //     Axios.get('http://localhost:5000/api/pacotes', {
    //         headers: { 'Authorization': 'Bearer ' + localStorage.getItem('usuario-codetur') }
    //     })
    //         .then(response => {
    //             this.setState({ lista: response.data })
    //             console.log({ lista: response.data })
    //         })
    // }

    render() {
        return (
            <div className="AppP">
                <header className="container">
                <div className="container">
                        <img src={logo} />
                 </div>
                 <div className="nn">
                 <Link id="Link" to='/lista'>Todos os pacotes</Link>
                 </div>
                 
                </header>
                <section className="conteudo">
                    <div className="cadastrar">
                        <div className="ihhmiga">
                            <h1>Cadastro de pacotes:</h1>
                        </div>
                        <div className="cadastar-conteudo">
                            <form onSubmit={this.Cadastrar}>
                                <div>
                                <div>
                                    <p>Oferta</p>
                                    <input type="text" name="username" onChange={this.estadoOferta}/>
                                </div>
                                    <p>Destino</p>
                                    <input type="text" name="username" onChange={this.estadoTitulo}/>
                                </div>

                                <div>
                                    <p>País</p>
                                    <input type="text" name="username" onChange={this.estadoPais}/>
                                </div>

                                <div>
                                    <p>Link da imagem</p>
                                    <input type="text" name="username" onChange={this.estadoImagem}/>
                                </div>
                                <div>
                                    <p>Descrição</p>
                                    <input type="text" name="username" onChange={this.estadoDescricao}/>
                                </div>
                                <div>
                                    <p>Data Inicial</p>
                                    <input type="text" name="username" onChange={this.estadoDataInicial}/>
                                </div>
                                <div>
                                    <p>Data Final</p>
                                    <input type="text" name="username" onChange={this.estadoDataFinal}/>
                                </div>
                                
                                <div>
                                    <p>Ativo</p>
                                    <input type="text" name="username" onChange={this.estadoAtivo}/>
                                </div>
                                
                            </form>
                        </div>
                    </div>

                    {/* <div className="listar">
                        <table className="tabela">
                            <thead className="tabela2">
                                <tr>
                                    <th scope="col">Título</th>
                                    <th scope="col">Imagem</th>
                                    <th scope="col">Descrição</th>
                                    <th scope="col">Data Inicial</th>
                                    <th scope="col">Data Final</th>
                                    <th scope="col">País</th>
                                    <th scope="col">Ativo</th>
                                    <th scope="col">Oferta</th>
                                </tr>
                            </thead>

                            <tbody id="tabela-pacotes-corpo">
                                {this.state.lista.map(element => {
                                    return (
                                        <tr key={element.idPacote}>
                                            <td>{element.titulo}</td>
                                            <td>{element.imagem}</td>
                                            <td>{element.descricao}</td>
                                            <td>{element.dataInicial}</td>
                                            <td>{element.dataFinal}</td>
                                            <td>{element.pais}</td>
                                            <td>{element.ativo}</td>
                                            <td>{element.oferta}</td>
                                        </tr>
                                    );
                                })}
                            </tbody>
                        </table>
                    </div> */}

                </section>
                <section className="gg">
                <Link id="Link" to='/lista'>Finalizar cadastro<br/></Link>
                </section>
                <br/>
                {/* <br/>
                 <Link id="Link" to='/App'>Logout</Link> */}
            </div>
        );
    }

}