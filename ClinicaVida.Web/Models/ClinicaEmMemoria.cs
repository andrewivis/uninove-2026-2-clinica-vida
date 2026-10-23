
using System.Collections.Generic;

namespace ClinicaVida.Web.Models;

public static class ClinicaEmMemoria
{
    public static List<Especialidade> Especialidades { get; } = new()
    {
        new Especialidade
        {
            Id = 1,
            Nome = "Cardiologia",
            Descricao = "Coração e vasos"
        },
        new Especialidade
        {
            Id = 2,
            Nome = "Pediatria",
            Descricao = "Saúde infantil"
        },
        new Especialidade
        {
            Id = 3,
            Nome = "Dermatologia",
            Descricao = "Pele, cabelos e unhas"
        },
        new Especialidade
        {
            Id = 4,
            Nome = "Ortopedia",
            Descricao = "Ossos e articulações"
        }
    };

    public static List<Medico> Medicos { get; } = new()
    {
        new Medico
        {
            Id = 1,
            Nome = "Dra. Marta Lisboa",
            Crm = "55307",
            EspecialidadeId = 1,
            Especialidade = Especialidades[0]
        },
        new Medico
        {
            Id = 2,
            Nome = "Dr. João Mendes",
            Crm = "62418",
            EspecialidadeId = 1,
            Especialidade = Especialidades[0]
        },
        new Medico
        {
            Id = 3,
            Nome = "Dra. Ana Ribeiro",
            Crm = "48321",
            EspecialidadeId = 2,
            Especialidade = Especialidades[1]
        },
        new Medico
        {
            Id = 4,
            Nome = "Dr. Pedro Costa",
            Crm = "71904",
            EspecialidadeId = 2,
            Especialidade = Especialidades[1]
        },
        new Medico
        {
            Id = 5,
            Nome = "Dra. Sofia Almeida",
            Crm = "81235",
            EspecialidadeId = 3,
            Especialidade = Especialidades[2]
        },
        new Medico
        {
            Id = 6,
            Nome = "Dr. Lucas Ferreira",
            Crm = "90561",
            EspecialidadeId = 4,
            Especialidade = Especialidades[3]
        }
    };
}
