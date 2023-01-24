﻿using System;
using MediatR;
using Notes.Application.Notes.Queries.GetNoteDetails;

namespace Notes.Application.Notes.Queries
{
    public class GetNoteDetailsQuery:IRequest<NoteDetailsVm>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
