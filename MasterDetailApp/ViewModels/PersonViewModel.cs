using Codeplex.Reactive;
using MasterDetailApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Codeplex.Reactive.Extensions;

namespace MasterDetailApp.ViewModels
{
    public class PersonViewModel
    {
        public Person Person { get; private set; }

        public ReactiveProperty<string> Name { get; private set; }

        public ReactiveProperty<int> Age { get; private set; }

        public PersonViewModel(Person person)
        {
            this.Person = person;

            this.Name = this.Person.ToReactivePropertyAsSynchronized(x => x.Name);
            this.Age = this.Person.ToReactivePropertyAsSynchronized(x => x.Age);
        }
    }
}
