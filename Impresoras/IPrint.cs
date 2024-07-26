using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

public interface IPrint
{
    void Print(Document doc);
}

public interface IScan
{
    void Scan(Document doc);
}