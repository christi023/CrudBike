using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CrudBike.Models.ViewModels
{
    public class ModelViewModel
    {
        public Model Model { get; set; }

        public IEnumerable<Make> Makes { get; set; }

        // making a list a select item list
        // SelectListItem is a method in ModelViewModel class to convert a IEnumerabme of make to the IEnumerable of selectlist item

        public IEnumerable<SelectListItem> CSelectListItem(IEnumerable<Make> Items)
        {
            List<SelectListItem> MakeList = new List<SelectListItem>();
            SelectListItem sli = new SelectListItem
            {// create the select dropdown
                Text = "----Select----",
                Value = "0"
            };

            MakeList.Add(sli);
            foreach (Make make in Items)
            {
                sli = new SelectListItem
                {
                    Text = make.Name,
                    Value = make.Id.ToString()
                };

                MakeList.Add(sli);
            }
            return MakeList;


        }
    }
}