<template>
  <div>
    <Jumbotron />
    <div class="container">
      <div class="row">
        <div class="col-md-4">
          <h3>Vue SPA Development</h3>
          <p class="text-muted">
            <small>
              Vue JS Framework as a main User Interface. components, data access
              using an Open Api js client.
            </small>
          </p>
        </div>
        <div class="col-md-4">
          <h3>Web Api/REST</h3>
          <p class="text-muted">
            <small>
              REST Services, JWT Tokens for user Access, best practices for
              building REST Services, Swagger, Open Api.
            </small>
          </p>
        </div>
        <div class="col-md-4">
          <h3>Clean Architecture</h3>
          <p class="text-muted">
            <small>
              Building using Clean Architecture and Clean Code principles, EF
              Core, MediatR, SQL Server, Docker with Project TYE.
            </small>
          </p>
        </div>
      </div>
    </div>

    <FeaturedProducts />
  </div>
</template>

<script>
import Jumbotron from "@/components/Jumbotron";
import FeaturedProducts from '@/components/FeaturedProducts'
export default {
  name: "Home",
  components: {
    Jumbotron,
    FeaturedProducts
  },
};
</script>
