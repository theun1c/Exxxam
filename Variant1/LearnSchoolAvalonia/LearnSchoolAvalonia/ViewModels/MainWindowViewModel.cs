using LearnSchoolAvalonia.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Linq;

namespace LearnSchoolAvalonia.ViewModels
{
    public partial class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Service> Services { get; } = new();
        public MainWindowViewModel()
        {
            using var db = new AppDbContext();

            var services = db.Services.Include(s => s.Image).ToList();
                
            foreach( var service in services)
            {
                Services.Add(service);
            }
        }
    }
}
