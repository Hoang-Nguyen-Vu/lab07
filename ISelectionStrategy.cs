//Hoàng Nguyên Vũ
//202419020
using System.Collections.Generic;
namespace DeviceManagement
{
    public interface ISelectionStrategy<T>
    {
        T Select(IReadOnlyList<T> candidates);
    }
}