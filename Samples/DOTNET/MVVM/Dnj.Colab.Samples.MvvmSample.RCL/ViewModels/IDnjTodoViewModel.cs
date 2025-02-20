﻿/* This file is copyright © 2022 Dnj.Colab repository authors.

Dnj.Colab content is distributed as free software: you can redistribute it and/or modify it under the terms of the General Public License version 3 as published by the Free Software Foundation, either version 3 of the License, or (at your option) any later version.

Dnj.Colab content is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the General Public License version 3 for more details.

You should have received a copy of the General Public License version 3 along with this repository. If not, see <https://github.com/smaicas-org/Dnj.Colab/blob/dev/LICENSE>. */

using System.ComponentModel;
using Dnj.Colab.Samples.MvvmSample.RCL.Model;

namespace Dnj.Colab.Samples.MvvmSample.RCL.ViewModels;

public interface IDnjTodoViewModel : INotifyPropertyChanged
{
    bool IsBusy { get; set; }
    int TodoItems { get; }
    TodoItem TodoItem { get; set; }
    List<TodoItem> TodoItemList { get; }

    Task SaveTodoItem(TodoItem todoitem);
}