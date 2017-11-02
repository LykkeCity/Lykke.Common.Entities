using System;

namespace Lykke.Contracts.Operations
{
    [Flags]
    public enum OperationStatus
    {
        Created,
        Accepted,
        Confirmed,
        Completed,
        Canceled,
        Failed
    }
}