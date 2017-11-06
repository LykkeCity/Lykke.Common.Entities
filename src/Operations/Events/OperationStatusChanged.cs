using System;

namespace Lykke.Contracts.Operations.Events
{
    public class OperationStatusChanged
    {
        public Guid Id { get; set; }
        public OperationStatus Status { get; set; }
    }
}