












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class Avg : ReqlExpr {

    
    
    
/// <summary>
/// <para>Averages all the elements of a sequence.  If called with a field name,
/// averages all the values of that field in the sequence, skipping
/// elements of the sequence that lack that field.  If called with a
/// function, calls that function on every element of the sequence and
/// averages the results, skipping elements of the sequence where that
/// function returns <code>null</code> or a non-existence error.</para>
/// </summary>
/// <example><para>Example: What's the average of 3, 5, and 7?</para>
/// <code>r.expr([3, 5, 7]).avg().run(conn, callback)
/// </code></example>
        public Avg (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Averages all the elements of a sequence.  If called with a field name,
/// averages all the values of that field in the sequence, skipping
/// elements of the sequence that lack that field.  If called with a
/// function, calls that function on every element of the sequence and
/// averages the results, skipping elements of the sequence where that
/// function returns <code>null</code> or a non-existence error.</para>
/// </summary>
/// <example><para>Example: What's the average of 3, 5, and 7?</para>
/// <code>r.expr([3, 5, 7]).avg().run(conn, callback)
/// </code></example>
        public Avg (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Averages all the elements of a sequence.  If called with a field name,
/// averages all the values of that field in the sequence, skipping
/// elements of the sequence that lack that field.  If called with a
/// function, calls that function on every element of the sequence and
/// averages the results, skipping elements of the sequence where that
/// function returns <code>null</code> or a non-existence error.</para>
/// </summary>
/// <example><para>Example: What's the average of 3, 5, and 7?</para>
/// <code>r.expr([3, 5, 7]).avg().run(conn, callback)
/// </code></example>
        public Avg (Arguments args, object optargs)
             : this(TermType.AVG, args, optargs) {
        }

    protected Avg (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
