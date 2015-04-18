using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkflowDemo.ClientWpf.Models;

namespace WorkflowDemo.ClientWpf.States
{
    public class TransitionMap : Dictionary<Type, Dictionary<StateTransition, Type>>
    {
    }
}
