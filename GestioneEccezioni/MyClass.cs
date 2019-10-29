using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneEccezioni
{
    class MyClass
    {
        public int Età { get; private set; }

        /// <summary>
        /// Imposta l'età della persona
        /// </summary>
        /// <param name="età">Descrizione parametro</param>
        /// <exception cref="CustomException">Una custom exception contenente l'eccezione reale</exception> 
        /// <seealso cref="SetEtà2"></seealso>
        public void SetEtà (string età)
        {
            try
            {
                Età = Int32.Parse(età);
            }
            catch (ArgumentNullException ex)
            {
                throw new CustomException("Il valore inserito è vuoto, inserire un valore corretto", ex);
            }
            catch (OverflowException ex)
            {
                throw new CustomException("Il valore inserito è troppo grande o troppo piccolo, inserire un valore corretto", ex);
            }
            catch (FormatException ex)
            {
                throw new CustomException("Il valore inserito non è numerico, inserire un valore corretto", ex);
            }
            catch
            {
                throw new CustomException("C'è stato un problema.");
            }
        }
    }
}
