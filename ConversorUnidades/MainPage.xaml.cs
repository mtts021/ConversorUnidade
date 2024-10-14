using System.Data;

namespace ConversorUnidades;

public partial class MainPage : TabbedPage
{

	public MainPage()
	{
		InitializeComponent();
	}
	private void CalcularDistancia(object sender, EventArgs e)
	{
		if(!string.IsNullOrEmpty(distanciaEntry.Text)) {
            try
            {
				int distanciaValue = int.Parse(distanciaEntry.Text);

				double distanciaConvertida = 0;
				if(unidadeDistancia.SelectedItem.ToString() == "KM")
				{
					switch (unidadeDistanciaAlvo.SelectedItem.ToString())
					{
						case "M": 
							distanciaConvertida = distanciaValue * 1000;
							break;
						
						case "CM": 
							distanciaConvertida = distanciaValue * 100000;
							break;
						default: 
							distanciaConvertida = distanciaValue;
							break;
					}
				} else if(unidadeDistancia.SelectedItem.ToString() == "M")
				{
					switch (unidadeDistanciaAlvo.SelectedItem.ToString())
					{
						case "KM": 
							distanciaConvertida = distanciaValue / 1000;
							break;
						
						case "CM": 
							distanciaConvertida = distanciaValue * 100;
							break;
						default: 
							distanciaConvertida = distanciaValue;
							break;
					}
				} else if(unidadeDistancia.SelectedItem.ToString() == "CM")
				{
					switch (unidadeDistanciaAlvo.SelectedItem.ToString())
					{
						case "KM": 
							distanciaConvertida = distanciaValue / 100000;
							break;
						
						case "M": 
							distanciaConvertida = distanciaValue / 100;
							break;
						default: 
							distanciaConvertida = distanciaValue;
							break;
					}
				}

				ResultadoDistancia.Text = distanciaConvertida.ToString(); 
			}
			catch (Exception)
            {
				DisplayAlert("Entrada Inválida", "Distancia deve ser um número inteiro", "FECHAR");
			}
		}
	}
	private void CalcularPeso(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(pesoEntry.Text))
        {
            return;
        }
        try
        {
			double pesoValor = double.Parse(pesoEntry.Text);

			double pesoConvertido = pesoValor;
			if(unidadePeso.SelectedItem.ToString() == "kg")
			{
				switch(unidadePesoAlvo.SelectedItem.ToString())
				{
					case "g":
						pesoConvertido = pesoValor * 1000;
						break;
					default: 
						pesoConvertido = pesoValor;
						break;
				}
			} else if(unidadePeso.SelectedItem.ToString() == "g")
			{
				switch(unidadePesoAlvo.SelectedItem.ToString())
				{
					case "kg":
						pesoConvertido = pesoValor / 1000;
						break;
				}
			}

			ResultadoPeso.Text = pesoConvertido.ToString();

        }
        catch (Exception)
        {
            DisplayAlert("Entrada Inválida", "Distancia deve ser um número inteiro", "FECHAR");
        }
    }
	private void CalcularTemperatura(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(temperaturaEntry.Text))
        {
            return;
        }
        try
        {
			double temperaturaValor = double.Parse(temperaturaEntry.Text);

			double temperaturaConvertido = temperaturaValor;
			if(unidadeTemperatura.SelectedItem.ToString() == "°C")
			{
				switch(unidadeTemperaturaAlvo.SelectedItem.ToString())
				{
					case "°F":
						temperaturaConvertido = temperaturaValor * 9/5 + 32;
						break;
				}
			}else if(unidadeTemperatura.SelectedItem.ToString() == "°F")
			{
				switch(unidadeTemperaturaAlvo.SelectedItem.ToString())
				{
					case "°C":
						temperaturaConvertido = (temperaturaValor - 32) * 5/9;
						break;
				}
			}

			ResultadoTemperatura.Text = temperaturaConvertido.ToString();

        }
        catch (Exception)
        {
            DisplayAlert("Entrada Inválida", "Distancia deve ser um número inteiro", "FECHAR");
        }
    }
}

