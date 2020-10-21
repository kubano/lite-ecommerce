<template>
  <header>
    <!-- Fixed navbar -->
    <nav class="navbar navbar-expand-md navbar-light fixed-top bg-light mb-4">
      <router-link class="navbar-brand" to="/">Lite E-Commerce</router-link>

      <button
        class="navbar-toggler"
        type="button"
        data-toggle="collapse"
        data-target="#navbarCollapse"
        aria-controls="navbarCollapse"
        aria-expanded="false"
        aria-label="Toggle navigation"
      >
        <span class="navbar-toggler-icon"></span>
      </button>
      <div class="collapse navbar-collapse" id="navbarCollapse">
        <ul class="navbar-nav mr-auto">
          <li class="nav-item active">
            <router-link class="nav-link" to="/products">Products</router-link>
          </li>
          <li class="nav-item">
            <router-link class="nav-link" to="/promos">Promos</router-link>
          </li>
        </ul>
        <span class="navbar-text">
          <ul class="navbar-nav mr-auto">
            <li class="nav-item" v-show="!isAuthenticated">
              <router-link
                to="/login"
                class="btn btn-sm btn-primary text-white mr-2">
                <i class="fas fa-sign-in-alt mr-1"></i>Sign In
              </router-link>
            </li>
            
            <li class="nav-item" v-show="!isAuthenticated">
              <a href="#" class="btn btn-sm btn-success text-white">
                <i class="fas fa-user-plus mr-1"></i>Register
              </a>
            </li>
            <li class="nav-item ml-2 mt-1">
              <router-link to="/cart">
                <i class="fas fa-shopping-cart mr-1"></i
                ><span
                  v-show="cartItems > 0"
                  id="js-cart-counter"
                  class="float-right badge badge-danger ml-2"
                  >{{ cartItems }}</span
                >Cart
              </router-link>
            </li>
          </ul>
        </span>
      </div>
    </nav>
  </header>
</template>
<script>
export default {
  name: "Navigation",
  data() {
    return {
      cartItems: 1,
    };
  },
  computed: {
    isAuthenticated: () => {
      return false;
    },
  },
};
</script>

<style scoped>
.router-link-exact-active {
  font-weight: 700;
  text-decoration: underline;
}
</style>
