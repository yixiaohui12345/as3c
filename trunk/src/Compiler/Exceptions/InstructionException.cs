/*
Copyright(C) 2007 Joa Ebert

As3c is an ActionScript 3 bytecode compiler for the AVM2.

As3c  is free software; you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation; either version 3 of the License, or
(at your option) any later version.

As3c is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>
*/
using System;
using System.Collections.Generic;
using System.Text;

namespace As3c.Compiler.Exceptions
{
    public class InstructionException : Exception
    {
        // Invalid syntax
        public enum Type
        {
            InvalidSyntax,
            NotEnoughArguments,
            TooManyArguments
        };

        protected DebugInformation _debugInfo;
        protected Type _errorType;

        public InstructionException( Type errorType, DebugInformation debugInfo )
        {
            _errorType = errorType;
            _debugInfo = debugInfo;
        }

        public DebugInformation DebugInfo { get { return _debugInfo; } }
        public Type ErrorType { get { return _errorType; } }
    }
}
