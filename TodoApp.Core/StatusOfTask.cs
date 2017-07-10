using System.ComponentModel.DataAnnotations;

namespace TodoApp.Core
{
    public enum StatusOfTask
    {
        [Display(Name = "Новая")]
        New,
        [Display(Name = "Выполняется")]
        InProgress,
        [Display(Name = "Отложена")]
        Postponded,
        [Display(Name = "Завершена")]
        Completed,
        [Display(Name = "Отменена")]
        Canceled
    }
}
