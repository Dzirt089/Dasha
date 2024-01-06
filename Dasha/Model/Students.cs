using System.ComponentModel.DataAnnotations;

namespace Dasha.Model
{
    public class Students
    {
        /// <summary>
        /// Индентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя клиента
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Фамилия клиента
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Ник клиента в телеграм 
        /// </summary>
        public string TelegramName { get; set; }

        /// <summary>
        /// Пароль для клиента, уникальный ключ.
        /// </summary>
        [Key]
        public string Password { get; set; }

        /// <summary>
        /// Чат id клиента в телеграм
        /// </summary>
        public long TelegramID { get; set; }
    }
}
