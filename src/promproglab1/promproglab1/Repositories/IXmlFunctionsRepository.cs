using promproglab1.Model;

namespace promproglab1.Repositories
{
    internal interface IXmlFunctionsRepository
    {
        void AddFunction(Function function);
        void InsertFunction(int index, Function function);
        void ReadFromFile();
        void RemoveAllFunction();
        void RemoveFunction(int index);
    }
}