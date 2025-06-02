using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppRpgEtec.Services.Personagens;

namespace AppRpgEtec.ViewModels.Personagens
{
    public class CadastroPersonagemViewModel : BaseViewModel
    {
        private PersonagemService pService;
        public CadastroPersonagemViewModel()
        {
            string token = Preferences.Get("UsusarioToken", string.Empty);
            pService = new PersonagemService(token);
        }

        #region AtributosPropriedades
        private int id;
        private string nome;
        private int pontosVida;
        private int forca;
        private int defesa;
        private int inteligencia;
        private int disputas;
        private int vitorias;
        private int derrotas;

        public int Id 
        { 
            get => id;
            set 
            {
                id = value;
                OnPropertyChanged();
            }
        }
        public string Nome 
        { 
            get => nome; 
            set 
            {
                nome = value;
                OnPropertyChanged();
            } 
        }
        public int PontosVida 
        {
            get => pontosVida; 
            set 
            {
                pontosVida = value;
                OnPropertyChanged();
            } 
        }
        public int Forca   
        {
            get => forca;
            set
            {
                forca = value;
                OnPropertyChanged();    
            }
        }
        public int Defesa 
        {
            get => defesa;
            set
            {
                defesa = value;
                OnPropertyChanged();
            }
        }
        public int Inteligencia { get => inteligencia; set => inteligencia = value; }
        public int Disputas { get => disputas; set => disputas = value; }
        public int Vitorias { get => vitorias; set => vitorias = value; }
        public int Derrotas { get => derrotas; set => derrotas = value; }
        #endregion
    }
}
