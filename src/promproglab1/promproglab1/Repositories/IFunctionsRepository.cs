using promproglab1.Model;
using System.Collections.Generic;

namespace promproglab1.Repositories
{
    public interface IFunctionsRepository
    {
        void AddFunction(Function function);
        void InsertFunction(int index, Function function);
        void RemoveAllFunction();
        void RemoveFunction(int index);
        List<Function> GetFunctions();
    }
}