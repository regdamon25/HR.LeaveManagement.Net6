using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Request.Commands
{
    public class DeleteLeaveTypeCommand : IRequest // <-- Dont have to add a data type i.e. <int> or <Unit>, if its not going to be returning anything
    {
        public int Id { get; set; }
    }
}
