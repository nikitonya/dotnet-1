using PromProgLab1.Model;
using System.Collections.Generic;

namespace PromProgLab1.Repositories
{
    public interface IFunctionsRepository
    {
        void AddFunction(Function function);
        void InsertFunction(int index, Function function);
        void RemoveAllFunction();
        void RemoveFunction(int index);
        List<Function> GetFunctions();

        bool ComparisonFunction(int index1, int index2);
    }
}