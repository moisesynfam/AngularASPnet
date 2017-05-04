﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Angular2AspNet.Migrations
{
    public partial class SeedFeaturesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

              migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature1')");
              migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature2')");
              migrationBuilder.Sql("INSERT INTO Features (Name) VALUES ('Feature3')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}