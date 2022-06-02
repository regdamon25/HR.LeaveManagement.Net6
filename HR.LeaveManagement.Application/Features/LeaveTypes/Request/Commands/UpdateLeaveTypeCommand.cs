using HR.LeaveManagement.Application.DTOs.LeaveType;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveTypes.Request.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>//represents a return code of 204 No Content
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
