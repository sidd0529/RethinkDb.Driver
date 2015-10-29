












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

    public class ForEach : ReqlExpr {

    
    
    
/// <summary>
/// <para>Loop over a sequence, evaluating the given write query for each element.</para>
/// </summary>
/// <example><para>Example: Now that our heroes have defeated their villains, we can safely remove them from the villain table.</para>
/// <code>r.table('marvel').forEach(function(hero) {
///     return r.table('villains').get(hero('villainDefeated')).delete()
/// }).run(conn, callback)
/// </code></example>
        public ForEach (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Loop over a sequence, evaluating the given write query for each element.</para>
/// </summary>
/// <example><para>Example: Now that our heroes have defeated their villains, we can safely remove them from the villain table.</para>
/// <code>r.table('marvel').forEach(function(hero) {
///     return r.table('villains').get(hero('villainDefeated')).delete()
/// }).run(conn, callback)
/// </code></example>
        public ForEach (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Loop over a sequence, evaluating the given write query for each element.</para>
/// </summary>
/// <example><para>Example: Now that our heroes have defeated their villains, we can safely remove them from the villain table.</para>
/// <code>r.table('marvel').forEach(function(hero) {
///     return r.table('villains').get(hero('villainDefeated')).delete()
/// }).run(conn, callback)
/// </code></example>
        public ForEach (Arguments args, object optargs)
             : this(TermType.FOR_EACH, args, optargs) {
        }

    protected ForEach (TermType termType, Arguments args, object optargs) : base(termType, args, optargs)
    {
    }


    



    


    

    


    
    }
}
