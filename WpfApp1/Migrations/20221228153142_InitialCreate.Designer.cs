﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WpfApp1.Context;

#nullable disable

namespace WpfApp1.Migrations
{
    [DbContext(typeof(AkimLib2DbContext))]
    [Migration("20221228153142_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.1");

            modelBuilder.Entity("AkimLib2.Core.Entities.Intruder.Intruder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nm")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Tls")
                        .HasColumnType("INTEGER");

                    b.Property<double>("VDro")
                        .HasColumnType("REAL");

                    b.HasKey("Id");

                    b.ToTable("Intruder", (string)null);
                });

            modelBuilder.Entity("AkimLib2.Core.Entities.Intruder.Intruder", b =>
                {
                    b.OwnsOne("AkimLib2.Core.Entities.Intruder.Params.IntruderEquipmentParams", "OsnH", b1 =>
                        {
                            b1.Property<int>("IntruderId")
                                .HasColumnType("INTEGER");

                            b1.Property<bool>("IsUsed")
                                .HasColumnType("INTEGER");

                            b1.Property<double>("ObstacleOvercomeTimeReduceCoef")
                                .HasColumnType("REAL");

                            b1.Property<double>("VelocityReduceCoef")
                                .HasColumnType("REAL");

                            b1.HasKey("IntruderId");

                            b1.ToTable("Intruder");

                            b1.WithOwner()
                                .HasForeignKey("IntruderId");
                        });

                    b.OwnsOne("AkimLib2.Core.Entities.Intruder.Params.IntruderEquipmentParams", "OsnL", b1 =>
                        {
                            b1.Property<int>("IntruderId")
                                .HasColumnType("INTEGER");

                            b1.Property<bool>("IsUsed")
                                .HasColumnType("INTEGER");

                            b1.Property<double>("ObstacleOvercomeTimeReduceCoef")
                                .HasColumnType("REAL");

                            b1.Property<double>("VelocityReduceCoef")
                                .HasColumnType("REAL");

                            b1.HasKey("IntruderId");

                            b1.ToTable("Intruder");

                            b1.WithOwner()
                                .HasForeignKey("IntruderId");
                        });

                    b.OwnsOne("AkimLib2.Core.Entities.Intruder.Params.IntruderEquipmentParams", "OsnM", b1 =>
                        {
                            b1.Property<int>("IntruderId")
                                .HasColumnType("INTEGER");

                            b1.Property<bool>("IsUsed")
                                .HasColumnType("INTEGER");

                            b1.Property<double>("ObstacleOvercomeTimeReduceCoef")
                                .HasColumnType("REAL");

                            b1.Property<double>("VelocityReduceCoef")
                                .HasColumnType("REAL");

                            b1.HasKey("IntruderId");

                            b1.ToTable("Intruder");

                            b1.WithOwner()
                                .HasForeignKey("IntruderId");
                        });

                    b.OwnsOne("AkimLib2.Core.Entities.Intruder.Params.IntruderAccomplicesParams", "AccomplicesParams", b1 =>
                        {
                            b1.Property<int>("IntruderId")
                                .HasColumnType("INTEGER");

                            b1.Property<bool>("Soo")
                                .HasColumnType("INTEGER");

                            b1.Property<double>("Tdvrs")
                                .HasColumnType("REAL");

                            b1.Property<double>("VVob")
                                .HasColumnType("REAL");

                            b1.Property<double>("VZad")
                                .HasColumnType("REAL");

                            b1.HasKey("IntruderId");

                            b1.ToTable("Intruder");

                            b1.WithOwner()
                                .HasForeignKey("IntruderId");
                        });

                    b.OwnsOne("AkimLib2.Core.Entities.Intruder.Params.IntruderCarParams", "CarParams", b1 =>
                        {
                            b1.Property<int>("IntruderId")
                                .HasColumnType("INTEGER");

                            b1.Property<bool>("HasCar")
                                .HasColumnType("INTEGER");

                            b1.Property<double>("VDrp")
                                .HasColumnType("REAL");

                            b1.Property<double>("VelocityIncreaseCoef")
                                .HasColumnType("REAL");

                            b1.HasKey("IntruderId");

                            b1.ToTable("Intruder");

                            b1.WithOwner()
                                .HasForeignKey("IntruderId");
                        });

                    b.OwnsOne("AkimLib2.Core.Entities.Intruder.Params.IntruderComplexionParams", "ComplexionParams", b1 =>
                        {
                            b1.Property<int>("IntruderId")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("HeightCrowlingMm")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("HeightSquattingMm")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("HeightStandingMm")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("LengthCrowlingMm")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("LengthSquattingMm")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("LengthStandingMm")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("WidthCrowlingMm")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("WidthSquattingMm")
                                .HasColumnType("INTEGER");

                            b1.Property<int>("WidthStandingMm")
                                .HasColumnType("INTEGER");

                            b1.HasKey("IntruderId");

                            b1.ToTable("Intruder");

                            b1.WithOwner()
                                .HasForeignKey("IntruderId");
                        });

                    b.OwnsOne("AkimLib2.Core.Entities.Intruder.Params.IntruderPsychophysicalParams", "PsychophysicalParams", b1 =>
                        {
                            b1.Property<int>("IntruderId")
                                .HasColumnType("INTEGER");

                            b1.Property<double>("RunDistanceMax")
                                .HasColumnType("REAL");

                            b1.Property<double>("RunDistanceMin")
                                .HasColumnType("REAL");

                            b1.Property<int>("TerritoryKnowledge")
                                .HasColumnType("INTEGER");

                            b1.Property<double>("VAir")
                                .HasColumnType("REAL");

                            b1.Property<double>("VHid")
                                .HasColumnType("REAL");

                            b1.Property<double>("VNap")
                                .HasColumnType("REAL");

                            b1.Property<double>("VOst")
                                .HasColumnType("REAL");

                            b1.Property<double>("VOtk")
                                .HasColumnType("REAL");

                            b1.Property<double>("VSch")
                                .HasColumnType("REAL");

                            b1.Property<double>("VSup")
                                .HasColumnType("REAL");

                            b1.HasKey("IntruderId");

                            b1.ToTable("Intruder");

                            b1.WithOwner()
                                .HasForeignKey("IntruderId");
                        });

                    b.OwnsOne("AkimLib2.Core.Entities.Intruder.Params.IntruderVelocityParams", "VelocityParams", b1 =>
                        {
                            b1.Property<int>("IntruderId")
                                .HasColumnType("INTEGER");

                            b1.Property<double>("VMax")
                                .HasColumnType("REAL");

                            b1.Property<double>("VMin")
                                .HasColumnType("REAL");

                            b1.Property<int>("VelocityMeasureUnit")
                                .HasColumnType("INTEGER");

                            b1.HasKey("IntruderId");

                            b1.ToTable("Intruder");

                            b1.WithOwner()
                                .HasForeignKey("IntruderId");
                        });

                    b.Navigation("AccomplicesParams")
                        .IsRequired();

                    b.Navigation("CarParams")
                        .IsRequired();

                    b.Navigation("ComplexionParams")
                        .IsRequired();

                    b.Navigation("OsnH")
                        .IsRequired();

                    b.Navigation("OsnL")
                        .IsRequired();

                    b.Navigation("OsnM")
                        .IsRequired();

                    b.Navigation("PsychophysicalParams")
                        .IsRequired();

                    b.Navigation("VelocityParams")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
