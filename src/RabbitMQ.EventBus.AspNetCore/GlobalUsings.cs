﻿global using Microsoft.Extensions.DependencyInjection;
global using Microsoft.Extensions.DependencyInjection.Extensions;
global using Microsoft.Extensions.Logging;
global using Polly;
global using Polly.Retry;
global using RabbitMQ.Client;
global using RabbitMQ.Client.Events;
global using RabbitMQ.Client.Exceptions;
global using RabbitMQ.EventBus.AspNetCore;
global using RabbitMQ.EventBus.AspNetCore.Attributes;
global using RabbitMQ.EventBus.AspNetCore.Configurations;
global using RabbitMQ.EventBus.AspNetCore.Events;
global using RabbitMQ.EventBus.AspNetCore.Factories;
global using RabbitMQ.EventBus.AspNetCore.Modules;
global using System;
global using System.Collections.Concurrent;
global using System.Collections.Generic;
global using System.ComponentModel;
global using System.IO;
global using System.Linq;
global using System.Net.Sockets;
global using System.Text;
global using System.Text.Encodings.Web;
global using System.Text.Json;
global using System.Text.Json.Serialization;
global using System.Threading;
global using System.Threading.Tasks;
