﻿// <auto-generated />
using System;
using Api.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Data.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20230918010238_Atendimento")]
    partial class Atendimento
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Api.Domain.Entities.AtendimentoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ClienteEntityId")
                        .HasColumnType("int");

                    b.Property<int>("ClienteId")
                        .HasColumnType("int")
                        .HasColumnName("client_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("DataAgendamento")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("scheduling_date");

                    b.Property<int?>("FuncionarioEntityId")
                        .HasColumnType("int");

                    b.Property<int>("FuncionarioId")
                        .HasColumnType("int")
                        .HasColumnName("employee_id");

                    b.Property<int>("ServicoEntityId")
                        .HasColumnType("int")
                        .HasColumnName("service_id");

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.Property<int?>("StatusAtendimentoEntityId")
                        .HasColumnType("int");

                    b.Property<int>("StatusAtendimentoId")
                        .HasColumnType("int")
                        .HasColumnName("service_status_id");

                    b.Property<int?>("TipoPagamentoEntityId")
                        .HasColumnType("int");

                    b.Property<int>("TipoPagamentoId")
                        .HasColumnType("int")
                        .HasColumnName("payment_type_id");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_update");

                    b.Property<string>("UsuarioCriacao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_create");

                    b.Property<decimal>("ValorASerPago")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("amount_to_be_paid");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("amount_paid");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("amount");

                    b.HasKey("Id");

                    b.HasIndex("ClienteEntityId");

                    b.HasIndex("FuncionarioEntityId");

                    b.HasIndex("ServicoEntityId");

                    b.HasIndex("StatusAtendimentoEntityId");

                    b.HasIndex("TipoPagamentoEntityId");

                    b.ToTable("customer_service");
                });

            modelBuilder.Entity("Api.Domain.Entities.CategoriaServicoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_update");

                    b.Property<string>("UsuarioCriacao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_create");

                    b.HasKey("Id");

                    b.ToTable("service_category");
                });

            modelBuilder.Entity("Api.Domain.Entities.ClienteEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apelido")
                        .HasColumnType("longtext")
                        .HasColumnName("nickname");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext")
                        .HasColumnName("cell_phone");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<string>("Genero")
                        .HasColumnType("longtext")
                        .HasColumnName("gender");

                    b.Property<int?>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Instagram")
                        .HasColumnType("longtext")
                        .HasColumnName("instagram");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<int>("ServicosFeitos")
                        .HasColumnType("int")
                        .HasColumnName("services_performed");

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.Property<string>("Telefone")
                        .HasColumnType("longtext")
                        .HasColumnName("phone");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_update");

                    b.Property<string>("UsuarioCriacao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_create");

                    b.Property<decimal>("ValorPago")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("amount_paid");

                    b.HasKey("Id");

                    b.ToTable("client");
                });

            modelBuilder.Entity("Api.Domain.Entities.FuncionarioEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Apelido")
                        .HasColumnType("longtext")
                        .HasColumnName("nickname");

                    b.Property<string>("Celular")
                        .HasColumnType("longtext")
                        .HasColumnName("cell_phone");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Email")
                        .HasColumnType("longtext")
                        .HasColumnName("email");

                    b.Property<int?>("Idade")
                        .HasColumnType("int")
                        .HasColumnName("age");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.Property<decimal?>("Porcentagem")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("percentage");

                    b.Property<int>("ServicosFeitos")
                        .HasColumnType("int")
                        .HasColumnName("services_performed");

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_update");

                    b.Property<string>("UsuarioCriacao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_create");

                    b.Property<decimal>("ValorGanho")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("earned_value");

                    b.Property<decimal>("ValorGanhoEmpresa")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("company_earned_value");

                    b.HasKey("Id");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("Api.Domain.Entities.ServicoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CategoriaServicoEntityId")
                        .HasColumnType("int")
                        .HasColumnName("categoria_servico_id");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<int>("DuracaoHoras")
                        .HasColumnType("int")
                        .HasColumnName("duration_hours");

                    b.Property<int>("DuracaoMinutos")
                        .HasColumnType("int")
                        .HasColumnName("duration_minutes");

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.Property<string>("Titulo")
                        .HasColumnType("longtext")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_update");

                    b.Property<string>("UsuarioCriacao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_create");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(18,2)")
                        .HasColumnName("value");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaServicoEntityId");

                    b.ToTable("service");
                });

            modelBuilder.Entity("Api.Domain.Entities.StatusAtendimentoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_update");

                    b.Property<string>("UsuarioCriacao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_create");

                    b.HasKey("Id");

                    b.ToTable("service_status");
                });

            modelBuilder.Entity("Api.Domain.Entities.TipoPagamentoEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext")
                        .HasColumnName("description");

                    b.Property<double>("JurosPorcentagem")
                        .HasColumnType("double")
                        .HasColumnName("interest_percentage");

                    b.Property<int>("QrtParcelas")
                        .HasColumnType("int")
                        .HasColumnName("installments_number");

                    b.Property<string>("Status")
                        .HasColumnType("longtext")
                        .HasColumnName("status");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<string>("UsuarioAlteracao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_update");

                    b.Property<string>("UsuarioCriacao")
                        .HasColumnType("longtext")
                        .HasColumnName("user_create");

                    b.HasKey("Id");

                    b.ToTable("payment_type");
                });

            modelBuilder.Entity("Api.Domain.Entities.AtendimentoEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.ClienteEntity", "ClienteEntity")
                        .WithMany()
                        .HasForeignKey("ClienteEntityId");

                    b.HasOne("Api.Domain.Entities.FuncionarioEntity", "FuncionarioEntity")
                        .WithMany()
                        .HasForeignKey("FuncionarioEntityId");

                    b.HasOne("Api.Domain.Entities.ServicoEntity", "ServiceEntity")
                        .WithMany()
                        .HasForeignKey("ServicoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Api.Domain.Entities.StatusAtendimentoEntity", "StatusAtendimentoEntity")
                        .WithMany()
                        .HasForeignKey("StatusAtendimentoEntityId");

                    b.HasOne("Api.Domain.Entities.TipoPagamentoEntity", "TipoPagamentoEntity")
                        .WithMany()
                        .HasForeignKey("TipoPagamentoEntityId");

                    b.Navigation("ClienteEntity");

                    b.Navigation("FuncionarioEntity");

                    b.Navigation("ServiceEntity");

                    b.Navigation("StatusAtendimentoEntity");

                    b.Navigation("TipoPagamentoEntity");
                });

            modelBuilder.Entity("Api.Domain.Entities.ServicoEntity", b =>
                {
                    b.HasOne("Api.Domain.Entities.CategoriaServicoEntity", "CategoriaServicoEntity")
                        .WithMany()
                        .HasForeignKey("CategoriaServicoEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CategoriaServicoEntity");
                });
#pragma warning restore 612, 618
        }
    }
}
